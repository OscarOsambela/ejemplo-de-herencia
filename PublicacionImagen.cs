class PublicacioImagen:Publicacion{
  //propiedad nueva
  public string URLIMAGEN{get;set;}

  //constructor por defecto
  public PublicacioImagen(){}

  //constructor parametrizado
  public PublicacioImagen(string titulo, string autor, string urlImagen, bool esPublico){
    this.TITULO = titulo;
    this.AUTOR = autor;
    this.URLIMAGEN = urlImagen;
    this.ESPUBLICO = esPublico;
  }
      public override string ToString(){
      return string.Format("{0} - {1} en {2} - Creado por {3}", this.ID, this.TITULO, this.URLIMAGEN, this.AUTOR);
    }
}
