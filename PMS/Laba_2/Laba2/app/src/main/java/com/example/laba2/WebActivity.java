package com.example.laba2;

import androidx.appcompat.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.Toast;
import android.webkit.WebView;

import com.example.laba2.R;

public class WebActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_web);
        Toast.makeText(this, "OK", Toast.LENGTH_LONG).show();
        WebView webView = (WebView) findViewById(R.id.web_view);
        webView.loadUrl("https://www.google.com/");
    }
}
