using System;
using System.Linq;
using IntroductionToMLML.Model;

namespace IntroductionToML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Predicting Image...");
            ModelInput input = new ModelInput();
            input.ImageSource = "https://ep01.epimg.net/verne/imagenes/2019/10/21/articulo/1571661515_258318_1571663010_noticia_normal.jpg";

            ModelOutput result = ConsumeModel.Predict(input);

            Console.WriteLine($"Result:\n Category: {result.Prediction} | Score: {result.Score.Max()*100}%");

        }
    }
}
