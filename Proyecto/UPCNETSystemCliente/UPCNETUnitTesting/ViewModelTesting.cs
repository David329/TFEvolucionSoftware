using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace UPCNETUnitTesting.ViewModel
{
    [TestFixture]
    class ViewModelTesting
    {
        public const string username = "username";
        public const string password = "password";
        public const string alumnoId = "alumno";
        public const string profesorId = "profesor";
        public const string cursoId = "curso";

        private UPCNETSystemCliente.ViewModel.Alumno.HorarioViewModel objHorarioViewModelAlumno;
        private UPCNETSystemCliente.ViewModel.Alumno.LstCursoViewModel objLstCursoViewModelAlumno;
        private UPCNETSystemCliente.ViewModel.Login._LoginViewModel objLoginViewModelLogin;
        private UPCNETSystemCliente.ViewModel.Profesor.HorarioViewModel objHorarioViewModelProfesor;
        private UPCNETSystemCliente.ViewModel.Profesor.LstAlumnoViewModel objLstAlumnoViewModelProfesor;
        private UPCNETSystemCliente.ViewModel.Profesor.LstCursoViewModel objLstCursoViewModelProfesor;
        
        [SetUp]
        public void Initialize()
        {
            objHorarioViewModelAlumno = new UPCNETSystemCliente.ViewModel.Alumno.HorarioViewModel();
            objLstCursoViewModelAlumno = new UPCNETSystemCliente.ViewModel.Alumno.LstCursoViewModel();
            objLoginViewModelLogin = new UPCNETSystemCliente.ViewModel.Login._LoginViewModel();
            objHorarioViewModelProfesor = new UPCNETSystemCliente.ViewModel.Profesor.HorarioViewModel();
            objLstAlumnoViewModelProfesor = new UPCNETSystemCliente.ViewModel.Profesor.LstAlumnoViewModel();
            objLstCursoViewModelProfesor = new UPCNETSystemCliente.ViewModel.Profesor.LstCursoViewModel();
        }

        [TestCase(username, password)]
        public void Login_LoginViewModel_GetSet(string Username, string Password) {
            objLoginViewModelLogin.UsuarioCodigo = Username;
            objLoginViewModelLogin.UsuarioPassword = Password;
            Assert.AreEqual(Username, objLoginViewModelLogin.UsuarioCodigo);
            Assert.AreEqual(Password, objLoginViewModelLogin.UsuarioPassword);
        }

        [TestCase(alumnoId)]
        public void Alumno_HorarioViewModel_Fill(string alumnoId) {
            Assert.Null(objHorarioViewModelAlumno.lstCursoClaseAlumno);
            objHorarioViewModelAlumno.Fill(alumnoId);
            Assert.NotNull(objHorarioViewModelAlumno.lstCursoClaseAlumno);
        }

        [TestCase(alumnoId)]
        public void Alumno_LstCursoViewModel_Fill(string alumnoId) {
            Assert.Null(objLstCursoViewModelAlumno.listCursoAlumnoReporte);
            objLstCursoViewModelAlumno.Fill(alumnoId);
            Assert.NotNull(objLstCursoViewModelAlumno.listCursoAlumnoReporte);
        }

        [TestCase(profesorId)]
        public void Profesor_HorarioViewModel_Fill(string profesorId)
        {
            Assert.Null(objHorarioViewModelProfesor.lstHorario);
            objHorarioViewModelProfesor.Fill(profesorId);
            Assert.NotNull(objHorarioViewModelProfesor.lstHorario);
        }

        [TestCase(cursoId)]
        public void Profesor_LstAlumnoViewModel_Fill(string cursoId)
        {
            Assert.Null(objLstAlumnoViewModelProfesor.lstAlumno);
            objLstAlumnoViewModelProfesor.Fill(cursoId);
            Assert.NotNull(objLstAlumnoViewModelProfesor.lstAlumno);
        }

        [TestCase(profesorId)]
        public void Profesor_LstCursoViewModel_Fill(string profesorId)
        {
            Assert.Null(objLstCursoViewModelProfesor.lstCurso);
            objLstCursoViewModelProfesor.Fill(cursoId);
            Assert.NotNull(objLstCursoViewModelProfesor.lstCurso);
        }

    }
}
