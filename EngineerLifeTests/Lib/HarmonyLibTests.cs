using Microsoft.VisualStudio.TestTools.UnitTesting;
using EngineerLife.Study;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using HarmonyLib;
using System.Reflection;
using EngineerLife.Lib;

namespace EngineerLife.Performance.Tests
{
    [TestClass()]
    public class HarmonyLibTests
    {

        [TestMethod()]
        public void HarmonyLibTests1()
        {
            // Arrange
            var hrHarmonyLib = new Lib.HarmonyLib();
            // Act
            var act = hrHarmonyLib.DoSomethingUsingOther(10);
            // Assert
            Assert.AreEqual(100,act);
        }

        [TestMethod()]
        public void HarmonyLibTests2()
        {
            // Arrange
            var hrHarmonyLib = new Lib.HarmonyLib();
            Patcher.DoPatching<HarmonyLibUsing, HarmonyLibUsingMock>("DoSomething");
            // Act
            var act = hrHarmonyLib.DoSomethingUsingOther(10);
            // Assert
            Assert.AreEqual(20, act);
        }

        [TestMethod()]
        public void HarmonyLibTests3()
        {
            // Arrange
            var hrHarmonyLib = new Lib.HarmonyLib();
            Patcher.UnpatchAll();
            // Act
            var act = hrHarmonyLib.DoSomethingUsingOther(10);
            // Assert
            Assert.AreEqual(20, act);
        }

    }

    public class HarmonyLibUsingMock
    {
        private bool isRunning;
        private int counter;

        public static int DoSomething(int input)
        {
            return input * 2;
        }
    }

    public class Patcher
    {
        // make sure DoPatching() is called at start either by
        // the mod loader or by your injector

        public static void DoPatching<T, T1>(string OriginalMethodName, string NewMethodName = null)
        {
            var harmony = new Harmony("123");
            harmony.UnpatchAll();
            var mOriginal = typeof(T).GetMethod(OriginalMethodName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            var mNew = typeof(T1).GetMethod(NewMethodName ?? OriginalMethodName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            Memory.DetourMethod(mOriginal, mNew);
        }

        public static void DoPatchingTemp<T, T1>(string OriginalMethodName, string NewMethodName = null)
        {
            var harmony = new Harmony("123");
            harmony.UnpatchAll();
            var mOriginal = typeof(T).GetMethod(OriginalMethodName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            var mNew = typeof(T1).GetMethod(NewMethodName ?? OriginalMethodName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            Memory.DetourMethod(mOriginal, mNew);
        }

        public static void UnpatchAll()
        {
            var harmony = new Harmony("123");
            harmony.UnpatchAll();
        }
    }
}