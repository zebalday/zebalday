public class Supervisor extends Empleado{

    // ATRIBUTOS
    private String departamento;
    private int gratificacion;
    
    // SETTERS 
    public void setDepartamento(String D)   {this.departamento = D;}
    public void setGratificacion(int G)     {this.gratificacion = G;}
    
    // GETTERS 
    public String getDepartamento()     {return this.departamento;}
    public int getGratificacion()       {return this.gratificacion;}
   
    // CONSTRUCTORES 
    public Supervisor(){}
    public Supervisor(String R, String N, String P, String M, String D, String T, String C, int S, String Dep){
        super (R, N, P, M, D, T, C, S);
        this.departamento = Dep;}
    
    // ESTADO - TOSTRING
    public String toString(){return super.toString()+
                                    "\nDepartamento: "+this.departamento+
                                    "\nGratificación: "+this.gratificacion;}
                                    
    // VERIFICACION DE SUELDO SUPERVISOR
    public void verificarSueldo(){
        if (super.getSueldo() >= 10000000 && super.getSueldo() <= 2000000){
            System.out.println  ("Sueldo cumple las condiciones.");}
        else{System.out.println ("Sueldo no cumple las condiciones. Será cambiado a $1.000.000 automáticamente.");
            super.setSueldo(1000000);
            System.out.println  ("Nuevo Sueldo: "+super.getSueldo());}}
                        
    // CALCULAR SUELDO
    public int calcularSueldo(){
        int sueldoBruto;
        if (this.departamento == "Finanzas"){this.gratificacion = 150000;}
        else if(this.departamento == "Ventas"){this.gratificacion = 100000;}
        else if(this.departamento == "Recursos Humanos"){this.gratificacion = 50000;}
        sueldoBruto = super.getSueldo() + this.gratificacion;
        return sueldoBruto;}
    
    







}
