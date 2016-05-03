using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

/// <summary>

/// Translate Text using Google Translate API’s

/// Google URL – http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}

/// </summary>

/// <param name=”input”>Input string</param>

/// <param name=”languagePair”>2 letter Language Pair, delimited by “|”.

/// E.g. “ar|en” language pair means to translate from Arabic to English</param>

/// <returns>Translated to String</returns>
namespace Translator
{

    public static class GetTranslation
    {

        public static string TranslateTextWithGoogle(string input, string languagePair)
        {
            try
            {
                string url = String.Format("http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}", input, languagePair);
                WebClient webClient = new WebClient();
                webClient.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
                webClient.Encoding = System.Text.Encoding.UTF8;
                string result = webClient.DownloadString(url);
                result = result.Substring(result.IndexOf("<span title=\"") + "<span title=\"".Length);
                result = result.Substring(result.IndexOf(">") + 1);
                result = result.Substring(0, result.IndexOf("</span>"));
                return result.Trim();
            }
            catch (WebException ex)
            {
                return ex.StackTrace;
            }
        }
    }
}