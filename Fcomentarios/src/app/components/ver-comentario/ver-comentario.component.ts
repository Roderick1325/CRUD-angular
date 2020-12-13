import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Comentario } from 'src/app/models/comentario';
import { ComentarioService } from 'src/app/services/comentario.service';

@Component({
  selector: 'app-ver-comentario',
  templateUrl: './ver-comentario.component.html',
  styleUrls: ['./ver-comentario.component.css']
})
export class VerComentarioComponent implements OnInit {
  loading = false;
  comentario: Comentario;
  idcomentario: number;

  constructor(private comenatrioService: ComentarioService, private route: ActivatedRoute) { 
    this.idcomentario = +this.route.snapshot.paramMap.get('id');
  }
  ngOnInit(): void {
    this.cargarComentario();
  }

  cargarComentario(){
    this.loading = true;
    this.comenatrioService.cargarComentario(this.idcomentario).subscribe(data => {
      this.loading = false;
      this.comentario = data;

    })
  }

}