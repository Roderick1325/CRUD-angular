import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from "@angular/forms";

import { HttpClientModule } from "@angular/common/http";

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AgregarEditarComentarioComponent } from './components/agregar-editar-comentario/agregar-editar-comentario.component';
import { ListComentariosComponent } from './components/list-comentarios/list-comentarios.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { VerComentarioComponent } from './components/ver-comentario/ver-comentario.component';

@NgModule({
  declarations: [
    AppComponent,
    AgregarEditarComentarioComponent,
    ListComentariosComponent,
    NavbarComponent,
    VerComentarioComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }