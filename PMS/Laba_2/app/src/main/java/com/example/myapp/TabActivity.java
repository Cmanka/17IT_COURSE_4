package com.example.myapp;

import android.os.Bundle;
import android.webkit.WebView;
import android.widget.TabHost;
import android.widget.Toast;
import androidx.appcompat.app.AppCompatActivity;

public class TabActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        Toast.makeText(this, "1", Toast.LENGTH_LONG).show();
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tab);
        WebView webView = (WebView) findViewById(R.id.web_view);

        TabHost tabHost = (TabHost) findViewById(android.R.id.tabhost);
        tabHost.setup();
        TabHost.TabSpec tabSpec;

        tabSpec = tabHost.newTabSpec("tag1");
        tabSpec.setContent(R.id.tab1);
        tabSpec.setIndicator("1 Tab");
        tabHost.addTab(tabSpec);

        tabSpec = tabHost.newTabSpec("tag2");
        tabSpec.setContent(R.id.tab2);
        tabSpec.setIndicator("2 Tab");
        tabHost.addTab(tabSpec);
        webView.loadUrl("https://www.google.com/");

        tabHost.setCurrentTabByTag("tag1");
    }
}
