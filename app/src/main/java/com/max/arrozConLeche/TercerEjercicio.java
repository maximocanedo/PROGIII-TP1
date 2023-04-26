package com.max.arrozConLeche;

import androidx.appcompat.app.AppCompatActivity;
import androidx.constraintlayout.widget.ConstraintLayout;

import android.os.Bundle;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.TextView;

import com.google.android.material.snackbar.Snackbar;

import java.util.ArrayList;
import java.util.List;

public class TercerEjercicio extends AppCompatActivity {

    // Controles
    private RadioGroup sexo, estadoCivil;
    private CheckBox dataEntry, operadorPC, programador, reparadorPC, tester;
    private Button btnMostrarSeleccionado;
    private TextView txtResultado;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tercer_ejercicio);
        sexo = findViewById(R.id.ej3radioGroupSexo);
        estadoCivil = findViewById(R.id.ej3radioGroupEstadoCivil);
        btnMostrarSeleccionado = findViewById(R.id.btnMostrarSeleccionado);
        txtResultado = findViewById(R.id.ej3txtResultado);
        dataEntry = findViewById(R.id.ej3cbDataEntry);
        operadorPC = findViewById(R.id.ej3cbOperadorPC);
        programador = findViewById(R.id.ej3cbProgramador);
        reparadorPC = findViewById(R.id.ej3cbReparadorPC);
        tester = findViewById(R.id.ej3cbTester);

        List<String> oficios = new ArrayList<String>();

        btnMostrarSeleccionado.setOnClickListener(view -> {
            String sexoSeleccionado = ((RadioButton)findViewById(sexo.getCheckedRadioButtonId())).getText().toString();
            String estadoCivilSeleccionado=((RadioButton)findViewById(estadoCivil.getCheckedRadioButtonId())).getText().toString();

            String resultado = "Seleccionaste: \n";
            resultado += "Sexo: " + sexoSeleccionado + "\n";
            resultado += "Estado Civil: " + estadoCivilSeleccionado + "\n";
            resultado += "Oficio/s: \n";
            for(int i = 0; i < oficios.size(); i++) {
                resultado += " · " + oficios.get(i) + "\n";
            }
            txtResultado.setText(resultado);
        });
        // Listener para todos los checkboxes
        CompoundButton.OnCheckedChangeListener checkboxListener = new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
                if(isChecked) {
                    oficios.add(buttonView.getText().toString());
                } else {
                    oficios.remove(buttonView.getText().toString());
                }
            }
        };
        dataEntry.setOnCheckedChangeListener(checkboxListener);
        operadorPC.setOnCheckedChangeListener(checkboxListener);
        programador.setOnCheckedChangeListener(checkboxListener);
        reparadorPC.setOnCheckedChangeListener(checkboxListener);
        tester.setOnCheckedChangeListener(checkboxListener);

    }
}