
class Publicacion{
  //variable
  private static int publicacionId;
  
    //propiedad
    protected int ID{get; set;}
    protected string TITULO{get; set;}
    protected string AUTOR{get; set;}
    protected bool ESPUBLICO{get; set;}

    //constructor por defecto
    public Publicacion(){
      ID = CrearId();
      TITULO = "Mi primera publicación";
      AUTOR = "Oscar Osambela";
      ESPUBLICO = true;
    }

    //constructor parametrizado
    public Publicacion(string titulo, bool esPublico, string autor){
      this.ID = CrearId();
      this.TITULO = titulo;
      this.AUTOR = autor;
      this.ESPUBLICO = esPublico;
    }

    //metodo para crear Id
    public int CrearId(){
      return ++publicacionId;
    }

    //metodo para editar publicacion
    public void Editar(string titulo, bool esPublico){
      this.TITULO = titulo;
      this.ESPUBLICO = esPublico;
    }
    public override string ToString(){
      return string.Format("{0} - {1} - Creado por {2}", this.ID, this.TITULO, this.AUTOR);
    }
  
  }
