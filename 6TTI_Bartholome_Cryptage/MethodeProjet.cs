namespace _6TTI_Bartholome_Cryptage
{
    public static class MethodeProjet
    {
        public static void CryptVigenere(string phraseClaire,string cleCryptage,out string[,] matriceVigenere)
        {
            matriceVigenere = new string[4, phraseClaire.Length];
            int positionCle = 0;

            for (int positionPhrase = 0; positionPhrase < phraseClaire.Length; positionPhrase++)
            {
                matriceVigenere[0, positionPhrase] = phraseClaire[positionPhrase].ToString();

                if (positionCle == cleCryptage.Length)
                {
                    positionCle = 0;
                }

                matriceVigenere[1, positionPhrase] = cleCryptage[positionCle].ToString();

                int decalage = cleCryptage[positionCle] - 65;
                matriceVigenere[2, positionPhrase] = decalage.ToString();

                int codeAscii;

                if (phraseClaire[positionPhrase] + decalage <= 90)
                {
                    codeAscii = phraseClaire[positionPhrase] + decalage;
                }
                else
                {
                    codeAscii = phraseClaire[positionPhrase] + decalage - 26;
                }

                matriceVigenere[3, positionPhrase] = Convert.ToChar(codeAscii).ToString();
                positionCle++;
            }
        }

        public static void CryptAffine(string phraseClaire,int coefficientA,int coefficientB,out string[,] matriceAffine)
        {
            matriceAffine = new string[4, phraseClaire.Length];

            for (int positionPhrase = 0; positionPhrase < phraseClaire.Length; positionPhrase++)
            {
                matriceAffine[0, positionPhrase] = phraseClaire[positionPhrase].ToString();

                int codeLettreClaire = phraseClaire[positionPhrase] - 65;
                matriceAffine[1, positionPhrase] = codeLettreClaire.ToString();

                int codeLettreChiffree =
                (coefficientA * codeLettreClaire + coefficientB) % 26;
                matriceAffine[2, positionPhrase] = codeLettreChiffree.ToString();

                matriceAffine[3, positionPhrase] =
                Convert.ToChar(codeLettreChiffree + 65).ToString();
            }
        }

        public static void ConcateneMatrice(string[,] matrice,out string texteMatrice)
        {
            texteMatrice = "";

            for (int ligne = 0; ligne < matrice.GetLength(0); ligne++)
            {
                for (int colonne = 0; colonne < matrice.GetLength(1); colonne++)
                {
                    texteMatrice += matrice[ligne, colonne] + " ";
                }

                texteMatrice += "\n";
            }
        }

        public static void NettoyagePhraseVigenere(ref string phraseClaire,ref string cleCryptage)
        {
            phraseClaire = phraseClaire.ToUpper().Replace(" ", "");
            cleCryptage = cleCryptage.ToUpper().Replace(" ", "");

            string phraseNettoyee = "";
            string cleNettoyee = "";

            for (int position = 0; position < phraseClaire.Length; position++)
            {
                if (phraseClaire[position] >= 'A' && phraseClaire[position] <= 'Z')
                {
                    phraseNettoyee += phraseClaire[position];
                }
            }

            for (int position = 0; position < cleCryptage.Length; position++)
            {
                if (cleCryptage[position] >= 'A' && cleCryptage[position] <= 'Z')
                {
                    cleNettoyee += cleCryptage[position];
                }
            }

            phraseClaire = phraseNettoyee;
            cleCryptage = cleNettoyee;
        }
        public static void NettoyagePhraseAffine(ref string phraseClaire)
        {
            phraseClaire = phraseClaire.ToUpper().Replace(" ", "");
            string phraseNettoyee = "";
            for (int position = 0; position < phraseClaire.Length; position++)
            {
                if (phraseClaire[position] >= 'A' && phraseClaire[position] <= 'Z')
                {
                    phraseNettoyee += phraseClaire[position];
                }
            }
            phraseClaire = phraseNettoyee;
        }
    }
}
