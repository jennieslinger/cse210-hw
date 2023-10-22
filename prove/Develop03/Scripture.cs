using System;
public class Scripture
{
    private string _singleVerseText;

    private string _multiVerseText;

    public Scripture()
    {
        _singleVerseText = "And if men come unto me I will show unto them their weakness. I will give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me, and have faith in me, then will I make weak things become strong unto them.";

        _multiVerseText = "And upon these I write the things of my soul, and many of the scriptures which are engraven upon the plates of brass. For my soul delighteth in the scriptures, and my heart pondereth them, and writeth them for the learning and the profit of my children. \n Behold, my soul delighteth in the things of the Lord; and my heart pondereth continually upon the things which I have seen and heard.";
    }

    public string GetSingleVerseTextString()
    {
        string text = _singleVerseText;
        return text;
    }

    public string GetMultiVerseTextString()
    {
        string text = _multiVerseText;
        return text;
    }

}