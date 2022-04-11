/*
 * AUTORES: Sebastián Alday Núñez - Rodrigo Olivares
 */

public class Principal {
    
    public static void main (String[] args){
    
        
    // CREANDO OBJETOS DE LA CLASE VENDEDOR 
    
    System.out.println("--------------------------------------------------------------------");
    System.out.println("-------------------------  V E N D E D O R E S ---------------------");
    System.out.println("--------------------------------------------------------------------");
    
    Vendedor V1 = new Vendedor("20151855-5", "Sebastian", "Alday", "Núñez", "Loicas 4201", "78894986", "V01", 400000, 0, 0);
    Vendedor V2 = new Vendedor("154518000-K","Alfredo", "Martínez", "Fredes", "Livorno 3187", "99695456","  V02", 400000, 0 ,0);
    
    System.out.println(V1.toString());
    System.out.println("");
    System.out.println(V2.toString());
    System.out.println("");
    
    
    // - Generando 10 ventas y calculando sueldo
    for (int x=0;x<10;x++){V1.venta(450000);}
    for (int x=0;x<10;x++){V2.venta(150000);}
    
    
    System.out.println("Ventas acumuladas vendedor 1: "+V1.getVentas());
    System.out.println("Comisiones acumuladas vendedor 1: "+V1.getComision());
    System.out.println("Sueldo bruto vendedor 1: "+V1.calcularSueldo());
    System.out.println("");
    
    System.out.println("Ventas acumuladas vendedor 2: "+V2.getVentas());
    System.out.println("Comisiones acumuladas vendedor 2: "+V2.getComision());
    System.out.println("Sueldo bruto vendedor 2: "+V2.calcularSueldo());
    System.out.println("");
    
    
    
    
    // CREANDO OBJETO DE LA CLASE SUPERVISOR
    
    System.out.println("--------------------------------------------------------------------");
    System.out.println("--------------------- S U P E R V I S O R E S ----------------------");
    System.out.println("--------------------------------------------------------------------");
    
    Supervisor S1 = new Supervisor("20151855-5", "Paulina", "Alday", "Núñez", "Leonidas Pérez 4201", "81303652", "S01",1500000, "Finanzas");
    Supervisor S2 = new Supervisor("20151855-5", "Hernan", "Hernandez", "Norambuena", "Las margaritas 4201", "67890102", "S02",1000000, "Recursos Humanos");
    
    System.out.println(S1.toString());
    System.out.println("Sueldo bruto: "+S1.calcularSueldo());
    System.out.println("");
    
    System.out.println(S2.toString());
    System.out.println("Sueldo bruto: "+S2.calcularSueldo());
    System.out.println("");
    
    S1.setSueldo(500000);
    S1.verificarSueldo();
    System.out.println("--------------------------------------------------------------------");
    System.out.println("");
    
    
    
    
    
    
    
    
    
    
    
   
    
    
    
    
    
    
    
    
    
    
    
    
    }
    
    
    
    
    
    
}
