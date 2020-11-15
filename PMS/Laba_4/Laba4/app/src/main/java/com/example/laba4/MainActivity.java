package com.example.laba4;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

import java.net.URI;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Toast.makeText(this, getIntent().getAction().toString(), Toast.LENGTH_LONG).show();
    }

    public void check_station(View view) {
        Intent intent = new Intent("com.example.metropicker.intent.action.PICK_METRO_STATION");
        startActivityForResult(intent, 1);
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        TextView view = findViewById(R.id.text);
        if (requestCode == 1)
            if (resultCode == RESULT_OK)
                view.setText(data.getData().toString());
            else if (resultCode == RESULT_CANCELED)
                view.setText("Никакой станции не выбрано");
    }

    public void check_station1(View view) {
        Intent intent = new Intent(this, ListViewActivity.class);
        startActivityForResult(intent, 1);
    }

    public void check_number(View view) {
//        Intent intent = new Intent(Intent.ACTION_DIAL, Uri.parse("tel:1233153"));
//        if (intent.resolveActivity(getPackageManager()) != null) {
//            startActivity(intent);
//        }
        Intent intent = new Intent(this,PhoneCheckerActivity.class);
        startActivityForResult(intent,1);
    }
}
