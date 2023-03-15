namespace Rap_Finands;

internal class Konto
{
	public string ejer;
	public string kontonr;
	public string registreringsnr;
	public List<Transaktion> transaktioner;

	public Konto()
	{
		transaktioner = new List<Transaktion>();
		registreringsnr = Program.reginummer; //Sæt registreringsnummer på kontoen!
		kontonr = Program.lavEtKontoNummer(); //Lav et nyt (tilfældigt shh!) kontonummer
	}
}
/** 
Koden er lavet til undervisningbrug på TECHCOLLEGE
Voldum Bank og nævnte personer er fiktive.
~Simon Hoxer Bønding
**/