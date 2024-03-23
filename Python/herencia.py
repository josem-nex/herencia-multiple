class Persona:
    def __init__(self, nombre, salario) -> None:
        self.nombre = nombre
        self.salario = salario 
    def CobrarSalario():
        # implementacion
        pass

class Trabajador(Persona): 
    def __init__(self, nombre, salario) -> None:
        super().__init__(nombre, salario)
    def CobrarSalario():
        print("Cobrando salario como trabajador")

class Estudiante(Persona):
    def __init__(self, nombre, salario) -> None:
        super().__init__(nombre, salario)
        self.horas_clase_recibidas = 0
        self.graduado = False
    def CobrarSalario(self):
        print("Cobrando salario como estudiante")
    def RecibirClases(self, horas: int):
        print("Recibiendo clases ...")
        self.horas_clase_recibidas += horas
        txt = "Horas clase recibidas: {} horas"
        print(txt.format(self.horas_clase_recibidas))

class Profesor(Trabajador):
    def __init__(self, nombre, salario) -> None:
        super().__init__(nombre, salario)
        self.horas_clase_impartidas = 0
        self.graduado = True
    def CobrarSalario(self):
        print("Cobrando salario como profesor")
    def ImpartirClases(self, horas: int):
        print("Impartiendo clases ...")
        self._horas_clase_impartidas += horas
        txt = "Horas clase impartidas: {} horas"
        print(txt.format(self.horas_clase_impartidas))

class AlumnoAyudante(Estudiante, Profesor):
    def __init__(self, nombre, salario) -> None:
        super().__init__(nombre, salario)
    def CobrarSalario(self):
        print("Cobrando salario como AlumnoAyudante")

class ProfesorAdiestrado(Profesor, Estudiante):
    def __init__(self, nombre, salario) -> None:
        super().__init__(nombre, salario)
    def CobrarSalario(self):
        print("Cobrando salario como ProfesorAdiestrado")
