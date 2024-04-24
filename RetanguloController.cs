using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGitub
{
    public class RetanguloController
    {
        private Retangulo _model;
        private RetanguloView _view;

        public RetanguloController(Retangulo model, RetanguloView view) { _model = model; _view = view; }

        public void SetRetanguloBase(double bas) {_model.Base = bas;}
        public double? GetRetanguloBase() { return _model.Base; }

        public void SetRetanguloAltura(double alt) { _model.Altura = alt;}
        public double? GetRetanguloAltura() { return _model.Altura; }

        public void AtualizarView() { _view.MostrarRetangulo(_model); }
    }
}
