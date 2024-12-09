import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HairtyleListComponent } from './hairtyle-list.component';

describe('HairtyleListComponent', () => {
  let component: HairtyleListComponent;
  let fixture: ComponentFixture<HairtyleListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [HairtyleListComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HairtyleListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
