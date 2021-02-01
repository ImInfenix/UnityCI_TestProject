using UnityEngine;
using Text = TMPro.TMP_Text;

public class ValueIncreaser : MonoBehaviour
{
    const int maxValue = 9;
    const int resetValue = 0;

    [SerializeField]
    private Text leftText;
    [SerializeField]
    private Text rightText;
    [SerializeField]
    private Text additionResult;

    private int leftValue;
    private int rightValue;

    private void Awake()
    {
        leftValue = resetValue;
        rightValue = resetValue;

        DisplayValues();
    }

    public void IncreaseLeft()
    {
        leftValue++;
        ClampValues();
    }

    public void IncreaseRight()
    {
        rightValue++;
        ClampValues();
    }

    private void ClampValues()
    {
        if (leftValue > maxValue)
            leftValue = resetValue;
        if (rightValue > maxValue)
            rightValue = resetValue;

        DisplayValues();
    }

    private void DisplayValues()
    {
        leftText.text = leftValue.ToString();
        rightText.text = rightValue.ToString();

        additionResult.text = (leftValue + rightValue).ToString();
    }
}
