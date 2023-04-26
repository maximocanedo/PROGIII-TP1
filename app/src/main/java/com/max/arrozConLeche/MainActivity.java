package com.max.arrozConLeche;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        // Controles
        Button btnPrimerEjercicio = findViewById(R.id.btnPrimerEjercicio)
             , btnSegundoEjercicio = findViewById(R.id.btnSegundoEjercicio)
             , btnTercerEjercicio = findViewById(R.id.btnTercerEjercicio);

        btnPrimerEjercicio.setOnClickListener(view -> {

        });
        btnSegundoEjercicio.setOnClickListener(view -> {

        });
        btnTercerEjercicio.setOnClickListener(view -> {

        });
    }
}