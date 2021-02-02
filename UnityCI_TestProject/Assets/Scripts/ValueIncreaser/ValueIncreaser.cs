using UnityEngine;
using Text = TMPro.TMP_Text;

public class ValueIncreaser : MonoBehaviour
{
    public const int maxValue = 9;
    public const int resetValue = 0;

    public Text leftText;
    public Text rightText;
    public Text additionResult;

    public int leftValue { get; private set; }
    public int rightValue { get; private set; }

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
        if(leftText != null)
        leftText.text = leftValue.ToString();
        if (rightText != null)
            rightText.text = rightValue.ToString();

        if (additionResult != null)
            additionResult.text = (leftValue + rightValue).ToString();
    }
}