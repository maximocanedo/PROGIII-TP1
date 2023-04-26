package com.max.arrozConLeche;

import androidx.activity.result.ActivityResultLauncher;
import androidx.activity.result.contract.ActivityResultContracts;
import androidx.appcompat.app.AppCompatActivity;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {
    private Button btnPrimerEjercicio, btnSegundoEjercicio, btnTercerEjercicio;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        // Controles
        btnPrimerEjercicio = findViewById(R.id.btnPrimerEjercicio);
        btnSegundoEjercicio = findViewById(R.id.btnSegundoEjercicio);
        btnTercerEjercicio = findViewById(R.id.btnTercerEjercicio);

        btnPrimerEjercicio.setOnClickListener(view -> {
            // Crear un Intent para ir a la actividad deseada
            Intent intent = new Intent(MainActivity.this, PrimerEjercicio.class);
            startActivity(intent);
        });
        btnSegundoEjercicio.setOnClickListener(view -> {
            Intent intent = new Intent(MainActivity.this, SegundoEjercicio.class);
            startActivity(intent);
        });
        btnTercerEjercicio.setOnClickListener(view -> {
            Intent intent = new Intent(MainActivity.this, TercerEjercicio.class);
            startActivity(intent);
        });
    }
}