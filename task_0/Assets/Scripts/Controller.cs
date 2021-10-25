using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

namespace task0
{

    public delegate int CountSumTruncDelegate(double sum, int pr);
    
    public class Controller : MonoBehaviour
    {
        [Header("INPUTS")]
        [SerializeField] private TMP_InputField InputField;
        [Space]
        [Header("BUTTONS")]
        [SerializeField] private Button HightProcentButton;
        [SerializeField] private Button MiddleProcentButton;
        [SerializeField] private Button LowProcentButton;
        [Space]
        [Header("LABELS")]
        [SerializeField] private TMP_Text HightProcentLabel;
        [SerializeField] private TMP_Text MiddleProcentLabel;
        [SerializeField] private TMP_Text LowProcentLabel;

        private readonly int hightProcent = 15;
        private readonly int middleProcent = 10;
        private readonly int lowProcent = 3;

        private string inputText;

        public event CountSumTruncDelegate countSumTrunc;

        private void Start()
        {
            HightProcentButton.onClick.AddListener(delegate {
                HightProcentLabel.text = countSumTrunc(Int32.Parse(inputText), hightProcent).ToString();
            });
            MiddleProcentButton.onClick.AddListener(delegate {
                MiddleProcentLabel.text = countSumTrunc(Int32.Parse(inputText), middleProcent).ToString();
            });
            LowProcentButton.onClick.AddListener(delegate {
                LowProcentLabel.text = countSumTrunc(Int32.Parse(inputText), lowProcent).ToString();
            });
        }

        public void SetSum()
        {
            inputText = InputField.text;
            Debug.Log(inputText);
        }
    }
}

