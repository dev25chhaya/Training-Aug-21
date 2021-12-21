import { Component, OnInit } from '@angular/core';
import { HeroService } from '../hero.service';
import { Hero } from '../hero';
import { MessageService } from '../message.service';

@Component({
  selector: 'app-heroes',
  templateUrl: './heroes.component.html',
  styleUrls: ['./heroes.component.css']
})
export class HeroesComponent implements OnInit {

  heroes: Hero[]=[];
  selecteHero?: Hero;

  constructor(private heroService: HeroService, private messageService: MessageService) { }


  getHeroes(): void{
    this.heroService.getHeroes().subscribe(heroes => this.heroes=heroes);
  }

  onSelect(hero: Hero): void{
    this.selecteHero= hero;
    this.messageService.add(`HeroComponet: Selected hero id=${hero.id}`);

  }

  ngOnInit(): void {
    this.getHeroes();
  }

}
