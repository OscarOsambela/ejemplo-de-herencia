class PublicacionVideo:Publicacion{
  public string URLVIDEO{get;set;}
	public int DURACION{get;set;}

	public PublicacionVideo(){}

	public PublicacionVideo(string titulo, string urlVideo, int duracion, string autor, bool esPublico){
		this.TITULO = titulo;
		this.URLVIDEO = urlVideo;
		this.DURACION = duracion;
	}

    public override string ToString(){
      return string.Format("{0} - Video '{1}', ver video en {2} con una duración de {3}segundos - Creado por {4}", this.ID, this.TITULO, this.URLVIDEO, this.DURACION,  this.AUTOR);
    }

}