using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion1SebastianAlday {
    internal class Menus {

        public Menus() { }


        public Int32 menu() {

            Console.Clear();

            Console.WriteLine("**********************************************");
            Console.WriteLine("*       SISTEMA DE EMPLEADOS Y VENTAS        *");
            Console.WriteLine("**********************************************");


            Console.WriteLine("\n ¿Qué desea hacer?:");
            Console.WriteLine("\n 1- Crear Supervisor.");
            Console.WriteLine(" 2- Menú Vendedor.");
            Console.WriteLine(" 3- Salir.");
            Console.Write("\n Opción:");


            try {

                int opcion = System.Convert.ToInt32(Console.ReadLine());

                while (opcion < 1 || opcion > 3) {
                    Console.Write("\nIngrese un número dentro de las opciones: ");
                    opcion = System.Convert.ToInt32(Console.ReadLine());
                }

                return opcion;
            }

            catch (Exception) {
                System.Console.Write("\n ERROR : Opción Inválida - Pulse para reintentar.");
                Console.ReadKey();
                return 0;
            }
        }



        public void MenuCrearSupervisor() {

            while (true) {

                try {

                    Console.Clear();

                    Console.WriteLine("**********************************************");
                    Console.WriteLine("*            EMPLEADO: SUPERVISOR            *");
                    Console.WriteLine("**********************************************");

                    // CREA OBJETO SUPERVISOR
                    Supervisor supervisor = new Supervisor();


                    // OBTIENE DATOS

                    Console.Write("\n Ingrese rut: ");
                    string R = Console.ReadLine();

                    Console.Write(" Ingrese nombres: ");
                    string N = Console.ReadLine();

                    Console.Write(" Ingrese apellidos paterno: ");
                    string AP = Console.ReadLine();

                    Console.Write(" Ingrese apellidos materno: ");
                    string AM = Console.ReadLine();

                    Console.Write(" Ingrese dirección: ");
                    string D = Console.ReadLine();

                    Console.Write(" Ingrese teléfono: ");
                    string T = Console.ReadLine();

                    Console.Write(" Ingrese código: ");
                    string C = Console.ReadLine();

                    Console.Write(" Ingrese Sueldo base: ");
                    double SB = Convert.ToDouble(Console.ReadLine());

                    string Dep = "";
                    double G = 0;

                    Console.WriteLine("\n -Seleccione un departamento: ");
                    Console.WriteLine(" 1) Finanzas.");
                    Console.WriteLine(" 2) Ventas.");
                    Console.WriteLine(" 3) Recursos Humanos.");
                    Console.Write("\n Opción:");

                    int opcion;

                    opcion = System.Convert.ToInt32(Console.ReadLine());

                    while (opcion < 1 || opcion > 3) {
                        Console.Write("\nIngrese un número dentro de las opciones: ");
                        opcion = System.Convert.ToInt32(Console.ReadLine());
                    }

                    switch (opcion) {
                        case 1:
                            Dep = "Finanzas";
                            G = 150000;
                            break;
                        case 2:
                            Dep = "Ventas";
                            G = 100000;
                            break;
                        case 3:
                            Dep = "Recursos Humanos";
                            G = 50000;
                            break;
                    }


                    // ASIGNA DATOS OBTENIDOS AL OBJETO DE SUPERVISOR

                    supervisor.setRUT(R);
                    supervisor.setNombre(N);
                    supervisor.setAp(AP);
                    supervisor.setAm(AM);
                    supervisor.setDireccion(D);
                    supervisor.setTelefono(T);
                    supervisor.setCodigo(C);
                    supervisor.setSueldoBase(SB);
                    supervisor.setDepto(Dep);
                    supervisor.setGrat(G);


                    // PAAAAAAAAUSA

                    Console.Write("\n Supervisor creado correctamente. Pulse para continuar.");
                    Console.ReadKey();


                    // RESULTADOS

                    Console.Clear();

                    Console.WriteLine("**********************************************");
                    Console.WriteLine("*            EMPLEADO: SUPERVISOR            *");
                    Console.WriteLine("**********************************************");


                    // VERIFICA SUELDO BASE ITRODUCIDO

                    supervisor.verificarSueldo();


                    // MUESTRA DATOS DEL SUPERVISOR

                    Console.WriteLine(" \n -- INFORMACIÓN DE SUPERVISOR -- \n");

                    Console.WriteLine(" RUT: " + supervisor.getRUT());
                    Console.WriteLine(" Nombre: " + supervisor.getNom());
                    Console.WriteLine(" A.Paterno: " + supervisor.getAp());
                    Console.WriteLine(" A.Materno: " + supervisor.getAm());
                    Console.WriteLine(" Dirección: " + supervisor.getDir());
                    Console.WriteLine(" Teléfono: " + supervisor.getTel());
                    Console.WriteLine(" Código: " + supervisor.getCodigo());
                    Console.WriteLine(" Sueldo Base: " + supervisor.getSueldoBase());
                    Console.WriteLine(" Departamento: " + supervisor.getDepto());
                    Console.WriteLine(" Gratificación: " + supervisor.getGrat());
                    Console.WriteLine(" Sueldo Bruto: " + supervisor.calcularSueldo());


                    Console.Write("\n Pulse para continuar.");
                    Console.ReadKey();
                    break;
                }

                catch (Exception) {
                    Console.Write("\n ERROR : Opción Inválida - Pulse para reintentar.");
                    Console.ReadKey();
                    continue;
                }
            }
        }



        public Int32 MenuVendedor() {

            Console.Clear();

            Console.WriteLine("**********************************************");
            Console.WriteLine("*          MENU VENDEDOR Y VENTAS            *");
            Console.WriteLine("**********************************************");


            Console.WriteLine("\n ¿Qué desea hacer?:");
            Console.WriteLine("\n 1- Crear vendedor.");
            Console.WriteLine(" 2- Generar ventas.");
            Console.WriteLine(" 3- Salir.");
            Console.Write("\n Opción:");


            try {

                int opcion = System.Convert.ToInt32(Console.ReadLine());

                while (opcion < 1 || opcion > 3) {
                    Console.Write("\nIngrese un número dentro de las opciones: ");
                    opcion = System.Convert.ToInt32(Console.ReadLine());
                }
                return opcion;
            }

            catch (Exception) {
                System.Console.Write("\n ERROR : Opción Inválida - Pulse para reintentar.");
                Console.ReadKey();
                return 0;
            }
        }



        public void MenuCrearVendedor() {

            while (true) {

                try {

                    Console.Clear();

                    Console.WriteLine("**********************************************");
                    Console.WriteLine("*             EMPLEADO: VENDEDOR             *");
                    Console.WriteLine("**********************************************");

                    // CREA OBJETO VENDEDOR
                    Vendedor vendedor = new Vendedor();


                    // OBTIENE DATOS

                    Console.Write("\n Ingrese rut: ");
                    string R = Console.ReadLine();

                    Console.Write(" Ingrese nombres: ");
                    string N = Console.ReadLine();

                    Console.Write(" Ingrese apellidos paterno: ");
                    string AP = Console.ReadLine();

                    Console.Write(" Ingrese apellidos materno: ");
                    string AM = Console.ReadLine();

                    Console.Write(" Ingrese dirección: ");
                    string D = Console.ReadLine();

                    Console.Write(" Ingrese teléfono: ");
                    string T = Console.ReadLine();

                    Console.Write(" Ingrese código: ");
                    string C = Console.ReadLine();

                    Console.WriteLine(" Sueldo base por defecto: 400000");
                    double SB = 400000;


                    // ASIGNA LOS DATOS OBTENIDOS AL VENDEDOR

                    vendedor.setRUT(R);
                    vendedor.setNombre(N);
                    vendedor.setAp(AP);
                    vendedor.setAm(AM);
                    vendedor.setDireccion(D);
                    vendedor.setTelefono(T);
                    vendedor.setCodigo(C);
                    vendedor.setSueldoBase(SB);


                    // PAAAAAAAAUSA

                    Console.WriteLine("\n Vendedor creado correctamente. Pulse para continuar.");
                    Console.ReadKey();

                    
                    // RESULTADOS

                    Console.Clear();

                    Console.WriteLine("**********************************************");
                    Console.WriteLine("*             EMPLEADO: VENDEDOR             *");
                    Console.WriteLine("**********************************************");

                    // MUESTRA DATOS DEL VENDEDOR

                    Console.WriteLine(" \n -- INFORMACIÓN DE VENDEDOR -- \n");

                    Console.WriteLine(" RUT: " + vendedor.getRUT());
                    Console.WriteLine(" Nombre: " + vendedor.getNom());
                    Console.WriteLine(" A.Paterno: " + vendedor.getAp());
                    Console.WriteLine(" A.Materno: " + vendedor.getAm());
                    Console.WriteLine(" Dirección: " + vendedor.getDir());
                    Console.WriteLine(" Teléfono: " + vendedor.getTel());
                    Console.WriteLine(" Código: " + vendedor.getCodigo());
                    Console.WriteLine(" Sueldo Base: " + vendedor.getSueldoBase());

                    Console.Write("\n Pulse para continuar.");
                    Console.ReadKey();

                    break;

                }

                catch (Exception) {
                    Console.Write("\n ERROR : Opción Inválida - Pulse para reintentar.");
                    Console.ReadKey();
                    continue;
                }
            }
        }



        public void MenuGenerarVenta() {

            while (true) {

                try {

                    Console.Clear();

                    Console.WriteLine("**********************************************");
                    Console.WriteLine("*             SISTEMA DE VENTAS              *");
                    Console.WriteLine("**********************************************");

                    // CREA VENDEDOR POR DEFECTO

                    Vendedor vendedor = new Vendedor();


                    // ASIGNA DATOS POR DEFECTO

                    vendedor.setRUT         ("20.151.855-5");
                    vendedor.setNombre      ("Sebastian");
                    vendedor.setAp          ("Alday");
                    vendedor.setAm          ("Nunez");            
                    vendedor.setDireccion   ("Livorno 3147");
                    vendedor.setTelefono    ("78894986");
                    vendedor.setCodigo      ("69");
                    vendedor.setSueldoBase  (400000);

                    
                    // INGRESA VENTA

                    Console.Write("\n Valor del producto: ");
                    double precio = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\n Cantidad: ");
                    double cantidad = Convert.ToDouble(Console.ReadLine());

                    
                    // ASIGNA VENTA Y COMISION A VENDEDOR
                    
                    double valor = precio * cantidad;

                    vendedor.setVentas(valor);


                    // CALCULA SUELDO (SUELDO BASE + COMISION POR VENTAS ACUMULADAS)

                    Console.WriteLine("\n -- CÁLCULO DE SUELDO -- ");

                    Console.WriteLine("\n Sueldo bruto del vendedor: " + vendedor.calcularSueldo() );

                    
                    // PAAAAAAAAAAUSA

                    Console.Write("\n Pulse para continuar.");
                    Console.ReadKey();

                    break;
                }

                catch (Exception) {
                    Console.Write("\n ERROR : Opción Inválida - Pulse para reintentar.");
                    Console.ReadKey();
                    continue;
                }
            }
        }

    }
}