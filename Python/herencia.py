class Persona:
    def __init__(self, nombre = "") -> None:
        self.nombre = nombre

class Trabajador(Persona): 
    def __init__(self, nombre="") -> None:
        super().__init__(nombre)
        self.salario_trabajador = 0
    def CobrarSalario(self, valor):
        # implementacion 
        self.salario_trabajador += valor

class Estudiante(Persona):
    def __init__(self, nombre="") -> None:
        super().__init__(nombre)
        self.salario_estudiante = 0
        self.clases_estudiante = []
        self.graduado = False
    def CobrarSalario(self, valor):
        # implementacion
        self.salario_estudiante += valor
    def AdicionarClase(self, clase):
        # implementacion 
        self.clases_estudiante.append(clase)
    def RecibirClases(self):
        # implementacion
        print("... recibiendo clases ...")
        for x in self.clases_estudiante:
            print(x)

class Profesor(Trabajador):
    def __init__(self, nombre="") -> None:
        super().__init__(nombre)
        self.clases_profesor = []
        self.graduado = True
    def CobrarSalario(self, valor):
        # implementacion
        self.salario_trabajador += valor
    def AdicionarClase(self, clase):
        # implementacion 
        self.clases_profesor.append(clase)
    def ImpartirClases(self):
        # implementacion
        print("... recibiendo clases ...")
        for x in self.clases_profesor:
            print(x)

class AlumnoAyudante(Estudiante, Profesor):
    def __init__(self, nombre="") -> None:
        super().__init__(nombre)

class ProfesorAdiestrado(Profesor, Estudiante):
    def __init__(self, nombre="") -> None:
        super().__init__(nombre)