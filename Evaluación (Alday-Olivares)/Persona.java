/**
 * @author (Sebastián Alday) 
 */

public class Persona{
    
    // ATRIBUTOS
    private String RUT;
    private String Nombres;
    private String apellido_paterno;
    private String apellido_materno;
    private String direccion;
    private String telefono;
    
    // SETTERS 
    public void setRUT(String R)        {this.RUT = R;}
    public void setNombres(String N)    {this.Nombres = N;}
    public void setAPaterno(String P)   {this.apellido_paterno = P;}
    public void setAMaterno(String M)   {this.apellido_materno = M;}
    public void setDir(String D)        {this.direccion = D;}
    public void setTelefono(String T)   {this.telefono = T;}
    
    // GETTERS
    public String getRUT()          {return this.RUT;}
    public String getNombres()      {return this.Nombres;}
    public String getAPaterno()     {return this.apellido_paterno;} 
    public String getAMaterno()     {return this.apellido_materno;}
    public String getDireccion()    {return this.direccion;}
    public String getTelefono()     {return this.telefono;}
    
    // CONSTRUCTORES
    public Persona(){}
    public Persona(String R, String N, String P, String M, String D, String T){
        this.RUT = R;
        this.Nombres = N;
        this.apellido_paterno = P;
        this.apellido_materno = M;
        this.direccion = D;
        this.telefono = T;}
    
    // ESTADO - TOSTRING
    public String toString(){return "RUT: "+this.RUT+
                                    "\nNombres: "+this.Nombres+
                                    "\nApellido paterno: "+this.apellido_paterno+
                                    "\nApellido materno: "+this.apellido_materno+
                                    "\nDirección: "+this.direccion+
                                    "\nTeléfono: "+this.telefono;}
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}

