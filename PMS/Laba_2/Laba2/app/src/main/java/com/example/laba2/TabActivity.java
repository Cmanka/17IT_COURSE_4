package com.example.laba2;


import android.os.Bundle;
import android.view.View;
import android.webkit.WebView;
import android.widget.Button;
import android.widget.TabHost;
import android.widget.TextView;
import android.widget.Toast;
import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.FragmentActivity;

import com.google.android.gms.maps.CameraUpdateFactory;
import com.google.android.gms.maps.GoogleMap;
import com.google.android.gms.maps.OnMapReadyCallback;
import com.google.android.gms.maps.SupportMapFragment;
import com.google.android.gms.maps.model.LatLng;
import com.google.android.gms.maps.model.MarkerOptions;

public class TabActivity extends FragmentActivity implements OnMapReadyCallback, View.OnClickListener {

    private GoogleMap mMap;
    public String str;
    public double a =55.486079;
    public double b = 28.763763;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        Toast.makeText(this, "1", Toast.LENGTH_LONG).show();
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tab);
        Button btn = (Button) findViewById(R.id.button2);
        btn.setOnClickListener((View.OnClickListener) this);
        // Obtain the SupportMapFragment and get notified when the map is ready to be used.
        SupportMapFragment mapFragment = (SupportMapFragment) getSupportFragmentManager()
                .findFragmentById(R.id.map);
        mapFragment.getMapAsync(this);
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

    public void onClick(View view) {
        TextView txt1 =  findViewById(R.id.editText1);
        TextView txt2 = findViewById(R.id.textView5);
        switch (view.getId()) {
            case R.id.button2:
                str = txt1.getText().toString();
                a = Double.parseDouble(str);
                str = txt2.getText().toString();
                b = Double.parseDouble(str);
                LatLng tmp = new LatLng(a, b);
                mMap.addMarker(new MarkerOptions().position(tmp).title("Your Marker"));
                mMap.moveCamera(CameraUpdateFactory.newLatLng(tmp));
                break;
            default:
                break;
        }
    }


    @Override
    public void onMapReady(GoogleMap googleMap) {
        mMap = googleMap;

        // Add a marker in Sydney and move the camera
        LatLng sydney = new LatLng(a, b);
        mMap.addMarker(new MarkerOptions().position(sydney).title("Marker in Sydney"));
        mMap.moveCamera(CameraUpdateFactory.newLatLng(sydney));
    }
}