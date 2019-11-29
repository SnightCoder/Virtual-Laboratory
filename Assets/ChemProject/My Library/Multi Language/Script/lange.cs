using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lange : MonoBehaviour
{
    //set language
    public static string lang = "VietNam";

    //language constant
    public readonly static string english_language = "English";
    public readonly static string vietnam_language = "VietNam";

    //key string
    public static string hello()
    {
        string ss = "";
        if (lang == english_language)
            ss = "Hello";
        else if (lang == vietnam_language)
            ss = "Xin chào";
        return ss;
    }

    public static string hi()
    {
        string ss = "";
        if (lang == english_language)
            ss = "Hi";
        else if (lang == vietnam_language)
            ss = "chào";
        return ss;
    }
    public static string changelanguage()
    {
        string ss = "";
        if (lang == english_language)
            ss = "Change Language";
        else if (lang == vietnam_language)
            ss = "Thay đổi ngôn ngữ ";
        return ss;
    }

    public static string setml()
    {
        string ss = "";
        if (lang == english_language)
            ss = "Volume: ";
        else if (lang == vietnam_language)
            ss = "Thể tích: ";
        return ss;
    }

    public static string leftArm()
    {
        string ss = "";
        if (lang == english_language)
            ss = "Left Arm: ";
        else if (lang == vietnam_language)
            ss = "Tay trái: ";
        return ss;
    }
    public static string RightArm()
    {
        string ss = "";
        if (lang == english_language)
            ss = "Right Arm: ";
        else if (lang == vietnam_language)
            ss = "Tay phải: ";
        return ss;
    }
}
