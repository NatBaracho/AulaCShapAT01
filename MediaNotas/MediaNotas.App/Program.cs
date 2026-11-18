using MediaNotas.App;

var avaliador = new AvaliadorNotas();
Console.WriteLine("Primeira nota: ");

double n1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Segunda nota: ");

double n2 = Convert.ToDouble(Console.ReadLine());
double media = avaliador.CalcularMedia(n1 , n2);

Console.WriteLine($"Media: {media: F1}");
Console.WriteLine(avaliador.Aprovado(media) ? "Aprovado" : "Reprovado");