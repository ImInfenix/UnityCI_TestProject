using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ValueIncreaserTests
    {
        [UnitySetUp]
        public IEnumerator SetupTests()
        {
            GameObject mainObj = new GameObject("Canvas");
            mainObj.AddComponent<Canvas>();
            mainObj.AddComponent<ValueIncreaser>();

            yield return null;
        }

        [UnityTearDown]
        public IEnumerator TearDownTests()
        {
            GameObject.Destroy(GameObject.FindObjectOfType<Canvas>().gameObject);
            yield return null;
        }

        [UnityTest, Timeout(1000)]
        public IEnumerator InitialValues()
        {
            ValueIncreaser valueIncreaser = GameObject.FindObjectOfType<ValueIncreaser>();
            Assert.AreEqual(ValueIncreaser.resetValue, valueIncreaser.leftValue);
            Assert.AreEqual(ValueIncreaser.resetValue, valueIncreaser.rightValue);
            yield return null;
        }

        [UnityTest, Timeout(1000)]
        public IEnumerator IncrementLeft()
        {
            ValueIncreaser valueIncreaser = GameObject.FindObjectOfType<ValueIncreaser>();
            int currentValue = valueIncreaser.leftValue;
            valueIncreaser.IncreaseLeft();
            Assert.AreEqual(currentValue + 1, valueIncreaser.leftValue);
            yield return null;
        }

        [UnityTest, Timeout(1000)]
        public IEnumerator IncrementLeftMaxValue()
        {
            ValueIncreaser valueIncreaser = GameObject.FindObjectOfType<ValueIncreaser>();
            while(valueIncreaser.leftValue < ValueIncreaser.maxValue)
            {
                valueIncreaser.IncreaseLeft();
                yield return null;
            }

            Assert.AreEqual(ValueIncreaser.maxValue, valueIncreaser.leftValue);
            yield return null;
        }

        [UnityTest, Timeout(1000)]
        public IEnumerator IncrementLeftClamp()
        {
            ValueIncreaser valueIncreaser = GameObject.FindObjectOfType<ValueIncreaser>();
            while (valueIncreaser.leftValue < ValueIncreaser.maxValue)
            {
                valueIncreaser.IncreaseLeft();
                yield return null;
            }

            valueIncreaser.IncreaseLeft();
            Assert.AreEqual(ValueIncreaser.resetValue, valueIncreaser.leftValue);
            yield return null;
        }

        [UnityTest, Timeout(1000)]
        public IEnumerator IncrementRight()
        {
            ValueIncreaser valueIncreaser = GameObject.FindObjectOfType<ValueIncreaser>();
            int currentValue = valueIncreaser.rightValue;
            valueIncreaser.IncreaseRight();
            Assert.AreEqual(currentValue + 1, valueIncreaser.rightValue);
            yield return null;
        }

        [UnityTest, Timeout(1000)]
        public IEnumerator IncrementRightMaxValue()
        {
            ValueIncreaser valueIncreaser = GameObject.FindObjectOfType<ValueIncreaser>();
            while(valueIncreaser.rightValue < ValueIncreaser.maxValue)
            {
                valueIncreaser.IncreaseRight();
                yield return null;
            }

            Assert.AreEqual(ValueIncreaser.maxValue, valueIncreaser.rightValue);
            yield return null;
        }

        [UnityTest, Timeout(1000)]
        public IEnumerator IncrementRightClamp()
        {
            ValueIncreaser valueIncreaser = GameObject.FindObjectOfType<ValueIncreaser>();
            while (valueIncreaser.rightValue < ValueIncreaser.maxValue)
            {
                valueIncreaser.IncreaseRight();
                yield return null;
            }

            valueIncreaser.IncreaseRight();
            Assert.AreEqual(ValueIncreaser.resetValue, valueIncreaser.rightValue);
            yield return null;
        }
    }
}
