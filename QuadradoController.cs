using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGitub
{
    public class QuadradoController
    {
        private Quadrado _model;
        private QuadradoView _view;

        public QuadradoController(Quadrado model, QuadradoView view) {_model = model; _view = view; }

        public void SetQuadradoLado(double lado) { _model.Lado = lado; }
        public double? GetQuadradoLado() { return _model.Lado; }

        public void AtualizarView() {_view.MostrarQuadrado(_model); }
    }
}
