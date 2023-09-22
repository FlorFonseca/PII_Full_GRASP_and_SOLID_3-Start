using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
        void PrintRecipe(Recipe recipe);
    }
}
/*
IPrinter depende de Recipe, ya que para poder hacer PrintRecipe la impresora debe conocer el contenido
de la receta.
*/