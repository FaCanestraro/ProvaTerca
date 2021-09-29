import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { Pessoa } from "src/app/models/pessoa";
import { PessoaService } from "src/app/services/pessoa.service";

@Component({
    selector: "app-cadastrar-pessoa",
    templateUrl: "./cadastrar-pessoa.component.html",
    styleUrls: ["./cadastrar-pessoa.component.css"],
})
export class CadastrarPessoaComponent implements OnInit {
    nome!: string;
    sobrenome!: string;
    cpf!: string;
    idade!: string;
    telefone!: string;

    constructor(private router: Router, private service: PessoaService) {}

    ngOnInit(): void {}

    cadastrar(): void {
        let pessoa: Pessoa = {
            nome: this.nome,
            sobrenome: this.sobrenome,
            cpf: this.cpf,
            idade: this.idade,
            telefone: this.telefone
            
        };
        this.service.create(pessoa).subscribe((pessoa) => {
            this.router.navigate(["pessoa/listar"]);
        });
    }
}
