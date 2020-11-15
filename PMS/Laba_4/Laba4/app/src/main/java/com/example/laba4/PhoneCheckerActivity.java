package com.example.laba4;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class PhoneCheckerActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_phone_checker);
    }

    public void clickButton(View view) {

        EditText editText = (EditText) findViewById(R.id.phoneText);
        String text = editText.getText().toString();
        System.out.println(text);
        Intent intent = new Intent(Intent.ACTION_DIAL, Uri.parse("tel:"+text));
        if (intent.resolveActivity(getPackageManager()) != null) {
            startActivity(intent);
        }
//        final EditText editText = (EditText) findViewById(R.id.phoneText);
//        String text = editText.getText().toString();
//        Intent data = new Intent(Intent.ACTION_DIAL);
//        data.setData(Uri.parse(text));
//        if (data.resolveActivity(getPackageManager()) != null) {
//            startActivity(data);
//        }
////        setResult(RESULT_OK, data);
////        finish();
    }

    @Override
    public void onBackPressed() {
        Intent returnIntent = new Intent();
        setResult(RESULT_CANCELED, returnIntent);
        finish();
    }
}