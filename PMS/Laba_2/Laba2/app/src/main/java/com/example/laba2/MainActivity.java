package com.example.laba2;

import android.content.Intent;
import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.FragmentActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity implements View.OnClickListener{


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Button btnC = (Button) findViewById(R.id.can);
        btnC.setOnClickListener(this);

        Button btnOk = (Button) findViewById(R.id.ok);
        btnOk.setOnClickListener(this);

        Button btnList = (Button) findViewById(R.id.list);
        btnList.setOnClickListener(this);
    }

    public void onClick(View view)
    {
        switch (view.getId())
        {
            case R.id.can:
                Intent intent = new Intent(this, TabActivity.class);
                startActivity(intent);
                Toast.makeText(this, "main", Toast.LENGTH_LONG).show();
                break;
            case R.id.ok:
                Intent intent1 = new Intent(this, WebActivity.class);
                startActivity(intent1);
                break;
            case R.id.list:
                Intent intent2 = new Intent(this, ListActivity.class);
                startActivity(intent2);
                break;
            default:
                break;
        }
    }
}