package com.max.arrozConLeche;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.os.Bundle;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;

import java.util.ArrayList;
import java.util.List;

public class SegundoEjercicio extends AppCompatActivity {
    private String getComparableString(String str) {
        String normalized = str.replaceAll("[\\s\\p{Punct}]", "");
        normalized = normalized
                .replaceAll("[áÁ]", "A")
                .replaceAll("[éÉ]", "E")
                .replaceAll("[íÍ]", "I")
                .replaceAll("[óÓ]", "O")
                .replaceAll("[úÚ]", "U");
        normalized = normalized.replaceAll("\\d+", "");
        normalized = normalized.toUpperCase();
        return normalized;
    }
    private EditText txtNombre, txtApellido;
    private Button btnAgregar, btnBorrar;
    private ListView l1;
    @SuppressLint("MissingInflatedId")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_segundo_ejercicio);
        txtNombre = findViewById(R.id.ej2txtNombre);
        txtApellido = findViewById(R.id.ej2txtApellido);
        btnAgregar = findViewById(R.id.ej2btnAgregar);
        btnBorrar = findViewById(R.id.ej2btnBorrar);
        l1 = findViewById(R.id.ej2listView1);
        List<String> elementos = new ArrayList<String>();

        MyAdapter adapter = new MyAdapter(this, elementos);
        l1.setAdapter(adapter);

        btnAgregar.setOnClickListener(view -> {
            String nombre = txtNombre.getText().toString();
            String apellido = txtApellido.getText().toString();
            String n_c = getComparableString(nombre);
            String a_c = getComparableString(apellido);
            if(n_c == "" || a_c == "") {
                txtNombre.setError((n_c=="")?"Ingrese un valor válido": null);
                txtApellido.setError((a_c=="")?"Ingrese un valor válido": null);
            } else {
                String finalName = nombre + " " + apellido;
                adapter.add(finalName);
            }
        });
        btnBorrar.setOnClickListener(view -> {
            List<String> vals = adapter.getValues();
            for(int i = 0; i < vals.size(); i++) {
                adapter.remove(vals.get(i));
            }
        });
    }
}