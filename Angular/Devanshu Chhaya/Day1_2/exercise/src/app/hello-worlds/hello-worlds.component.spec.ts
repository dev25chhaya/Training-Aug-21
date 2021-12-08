import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HelloWorldsComponent } from './hello-worlds.component';

describe('HelloWorldsComponent', () => {
  let component: HelloWorldsComponent;
  let fixture: ComponentFixture<HelloWorldsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HelloWorldsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HelloWorldsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
