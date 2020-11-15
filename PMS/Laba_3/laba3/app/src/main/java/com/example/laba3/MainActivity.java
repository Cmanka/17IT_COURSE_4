package com.example.laba3;

import android.content.Intent;
import android.os.Bundle;
import android.view.KeyEvent;
import android.view.View;
import android.widget.*;
import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        final EditText userName = (EditText) findViewById(R.id.user_name);
        userName.setOnKeyListener(new View.OnKeyListener() {
            @Override
            public boolean onKey(View v, int keyCode, KeyEvent event) {
                if ((event.getAction() == KeyEvent.ACTION_DOWN)
                        && (keyCode == KeyEvent.KEYCODE_ENTER)) {
                    Toast.makeText(getApplicationContext(),
                            userName.getText(), Toast.LENGTH_SHORT).show();
                    return true;
                }
                return false;
            }
        });

    }

    public void onButtonClicked(View v) {
        Toast.makeText(this, "Button clicked", Toast.LENGTH_SHORT).show();
        Intent intent = new Intent(this, com.example.laba3.DBActivity.class);
        startActivity(intent);
    }

    public void onButtonClicked1(View view) {
        Intent intent = new Intent(this, com.example.laba3.AdapterDBActivity.class);
        startActivity(intent);
    }

    public void onCheckboxClicked(View v) {
        if (((CheckBox) v).isChecked()) {
            Toast.makeText(this, "CheckBox on", Toast.LENGTH_SHORT).show();
        } else {
            Toast.makeText(this, "CheckBox off", Toast.LENGTH_SHORT).show();
        }
    }

    public void onToggleClicked(View v) {
        if (((ToggleButton) v).isChecked()) {
            Toast.makeText(this, "Toggle on", Toast.LENGTH_SHORT).show();
        } else {
            Toast.makeText(this, "Toggle off", Toast.LENGTH_SHORT).show();
        }
    }

    public void onRadioButtonClicked(View v) {
        RadioButton rb = (RadioButton) v;
        Toast.makeText(this, "Radio selected: " + rb.getText(),
                Toast.LENGTH_SHORT).show();
    }

    public void clean(View view) {
        EditText userName = (EditText) findViewById(R.id.user_name);
        userName.setText("", TextView.BufferType.EDITABLE);
    }


}
