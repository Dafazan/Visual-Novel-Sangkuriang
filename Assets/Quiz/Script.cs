using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Script : MonoBehaviour
{

    public GameObject panelQ;
    public GameObject panelNtc;

    public TextAsset assetSoal;
    private string[] soal;
    private string[,] soalBag;

    public TextMeshProUGUI Quest, optA, optB, optC, optD;

    int indexSoal;
    public int maxSoal;
    bool ambilSoal;
    char kunciJ;

    bool isHasil;
    private float durasi;
    public float durasiPenilaian;

    int jwbBenar, jwbSalah;
    float nilai;

    public GameObject imgPenilaian, imgHasil;
    public TextMeshProUGUI txtHasil, txtPredikat;

    bool[] soalSelesai;

    public string predikat;

    void Start()
    {
        
    }

    public void StartQuiz()
    {
        panelQ.SetActive(true);
        panelNtc.SetActive(false);

        durasi = durasiPenilaian;
        soal = assetSoal.ToString().Split('#');
        soalSelesai = new bool[soal.Length];
        soalBag = new string[soal.Length, 6];
        
        ambilSoal = true;
        ProceedQuiz();
        ShowQuiz();
        print(soalBag[1, 3]);
    }

    private void ProceedQuiz()
    {
        for (int i = 0; i < soal.Length; i++)
        {
            string[] tempSoal = soal[i].Split('+');
            for (int j = 0; j < tempSoal.Length; j++)
            {
                soalBag[i, j] = tempSoal[j];
            }
        }
    }

    private void ShowQuiz()
    {
        if (indexSoal < maxSoal)
        {
            if (ambilSoal)
            {
                for(int i=0; i < soal.Length; i++)
                {
                    int randomIndexSoal = Random.Range(0, soal.Length);
                    print(randomIndexSoal);
                    if (!soalSelesai[randomIndexSoal])
                    {
                        Quest.text = soalBag[randomIndexSoal, 0];
                        optA.text = soalBag[randomIndexSoal, 1];
                        optB.text = soalBag[randomIndexSoal, 2];
                        optC.text = soalBag[randomIndexSoal, 3];
                        optD.text = soalBag[randomIndexSoal, 4];
                        kunciJ = soalBag[randomIndexSoal, 5][0];
                        soalSelesai[randomIndexSoal] = true;
                        ambilSoal = false;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }

    public GameObject panel;
    public void Option(string opsiHuruf)
    {
        Check(opsiHuruf[0]);
       
        if(indexSoal == maxSoal - 1)
        {
            isHasil = true;

        }
        else
        {
            indexSoal++;
            ambilSoal = true;
        }
        panel.SetActive(true);
    }

    private float Count()
    {
        return nilai = (float)jwbBenar / maxSoal * 100;
    }

    public TextMeshProUGUI txtPenilaian;

    private void Check(char opt)
    {
        string penilaian;

        if (opt.Equals(kunciJ))
        {
            penilaian = "BENAR!";
            jwbBenar++;
        }
        else
        {
            penilaian = "SALAH!";
            jwbSalah++;
        }
        txtPenilaian.text = penilaian;
    }

    void Update()
    {
        if (nilai == 100)
        {
            predikat = "(A+) Sangat Mengerti";
        }
        else if (nilai >= 90)
        {
            predikat = "(A) Sangat Mengerti";
        }
        else if (nilai >= 70)
        {
            predikat = "(B) Mengerti";
        }
        else if (nilai >= 50)
        {
            predikat = "(C) Cukup Mengerti";
        }
        else if (nilai >= 30)
        {
            predikat = "(D) Kurang Mengerti";
        }
        else
        {
            predikat = "(E) Tidak Mengerti";
        }

        txtPredikat.text = predikat;


        if (panel.activeSelf)
        {
            durasiPenilaian -= Time.deltaTime;
           
            if (isHasil)
            {
                imgPenilaian.SetActive(true);
                imgHasil.SetActive(false);

                if (durasiPenilaian <= 0)
                {
                    txtHasil.text = "Jumlah Benar: " + jwbBenar + "\nJumlah Salah: " + jwbSalah + "\nSkor: " + Count();

                    imgPenilaian.SetActive(false);
                    imgHasil.SetActive(true);

                    durasiPenilaian = 0;
                }
            }
            else
            {
                imgPenilaian.SetActive(true);
                imgHasil.SetActive(false);
                if (durasiPenilaian <= 0)
                {
                    panel.SetActive(false);
                    durasiPenilaian = durasi;

                    ShowQuiz();
                }
            } 
        }
    }
    public void Quit()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Restart()
    {
        SceneManager.LoadScene("Quiz2");
    }
}




//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using TMPro;

//public class Script : MonoBehaviour
//{
//    public TextAsset assetSoal;
//    private string[] soal;
//    private string[,] soalBag;

//    public TextMeshProUGUI Quest, optA,optB,optC,optD;

//    int indexSoal;
//    int maxSoal;
//    bool ambilSoal;
//    char kunciJ;

//    void Start()
//    {
//      soal = assetSoal.ToString().Split('#');
//        soalBag = new string[soal.Length, 6];
//        maxSoal = soal.Length;
//        ambilSoal = true;
//        ProceedQuiz();
//        ShowQuiz();
//        print(soalBag[1,3]);
//    }
//    private void ProceedQuiz() {
//        for(int i=0; i< soal.Length; i++)
//        {
//            string[] tempSoal = soal[i].Split('+');
//            for(int j=0; j < tempSoal.Length; j++)
//            {
//                soalBag[i, j] = tempSoal[j];
//                continue;
//            }
//            continue;
//        }

//    }

//    private void ShowQuiz()
//    {
//        if(indexSoal < maxSoal)
//        {
//            if (ambilSoal)
//            {
//                Quest.text = soalBag[indexSoal, 0];
//                optA = soalBag[indexSoal, 1];
//                optB = soalBag[indexSoal, 2];
//                optC = soalBag[indexSoal, 3];
//                optD = soalBag[indexSoal, 4];
//                kunciJ = soalBag[indexSoal, 5][0];
//                ambilSoal = false;
//            }
//        }
//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }
//}
