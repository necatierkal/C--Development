namespace MethodsDemo;

internal class TextHelper
{
    //Metod Adı: PascalCase , parametreler: camelCase
    public string ToTitleCase(string ifade)
    {
        string cikti = ifade[0].ToString().ToUpper();

        cikti = HarfleriAyarla(ifade, cikti);

        return cikti;

        static string HarfleriAyarla(string ifade, string cikti)
        {
            for (int i = 1; i < ifade.Length; i++)
            {
                if (ifade[i] == ' ')
                {
                    cikti += ' ' + ifade[i + 1].ToString().ToUpper();
                    i++;
                    continue;
                }

                cikti += ifade[i].ToString().ToLower();
            }

            return cikti;
        }
    }
}
