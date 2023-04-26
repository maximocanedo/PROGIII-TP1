package com.max.arrozConLeche;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.os.Bundle;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;

import java.util.ArrayList;
import java.util.List;

public class PrimerEjercicio extends AppCompatActivity {
    private Button btnAgregar, btnMover, btnMoverTodo;
    private EditText txtNombre;
    private ListView l1, l2;
    @SuppressLint("MissingInflatedId")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_primer_ejercicio);
        btnAgregar = findViewById(R.id.ej1btnAgregar);
        txtNombre = findViewById(R.id.ej1txtNombre);
        l1 = findViewById(R.id.ej1listView1);
        l2 = findViewById(R.id.ej1listView0);
        btnMover = findViewById(R.id.ej1btnMover);
        btnMoverTodo = findViewById(R.id.ej1btnMoverTodo);
        List<String> elementos = new ArrayList<String>();
        List<String> elementos2 = new ArrayList<String>();
        elementos.add("Hola");
        MyAdapter adapter = new MyAdapter(this, elementos);
        MyAdapter adapter2 = new MyAdapter(this, elementos2);
        l1.setAdapter(adapter);
        l2.setAdapter(adapter2);
        btnAgregar.setOnClickListener(view -> {
            String nom = txtNombre.getText().toString();
            adapter.add(nom);
            txtNombre.setText("");
        });
        btnMover.setOnClickListener(view -> {
            List<String> selectedValues = adapter.getSelectedValues();
            for(int i = 0; i < selectedValues.size(); i++) {
                adapter2.add(selectedValues.get(i));
                adapter.remove(selectedValues.get(i));
            }
        });
        btnMoverTodo.setOnClickListener(view -> {
            List<String> vals = adapter.getValues();
            for(int i = 0; i < vals.size(); i++) {
                adapter2.add(vals.get(i));
                adapter.remove(vals.get(i));
            }
        });

    }
}