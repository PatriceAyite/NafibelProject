import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HairStylesComponent } from './hair-styles.component';

describe('HairStylesComponent', () => {
  let component: HairStylesComponent;
  let fixture: ComponentFixture<HairStylesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [HairStylesComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HairStylesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
