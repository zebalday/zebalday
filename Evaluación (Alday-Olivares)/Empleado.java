public class Empleado extends Persona{
   
    // ATRIBUTOS
    private String codigo;
    private int sueldo_base;
    
    // SETTERS 
    public void setCodigo(String C)     {this.codigo = C;}
    public void setSueldo(int S)        {this.sueldo_base = S;}
    
    // GETTERS 
    public String getCodigo()   {return this.codigo;}
    public int getSueldo()      {return this.sueldo_base;}
    
    // CONSTRUCTORES
    public Empleado(){}
    public Empleado(String R, String N, String P, String M, String D, String T, String C, int S){
        super (R, N, P, M, D, T);
        this.codigo = C;
        this.sueldo_base = S;}
    
    // ESTADO - TOSTRING
    public String toString(){return super.toString()+
                                    "\nCódigo Empleado: "+this.codigo+
                                    "\nSueldo Base: "+this.sueldo_base;}
    
   
   
                                    
                                    
                                    
                                    
                                    
                                    
                                    
}
