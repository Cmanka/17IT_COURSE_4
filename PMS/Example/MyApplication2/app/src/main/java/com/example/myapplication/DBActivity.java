package com.example.myapplication;

import android.content.Context;
import android.os.Bundle;
import android.view.ContextMenu;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;
import androidx.appcompat.app.AppCompatActivity;

import java.lang.reflect.Array;
import java.util.Arrays;
import java.util.LinkedList;
import java.util.List;

public class DBActivity extends AppCompatActivity {
    DatabaseHandler db;
    CharSequence text;
    private int CM_DELETE_ID = 1;
    ListView list;
    List<String> contacts;
    ArrayAdapter<String> aa;
    int pos;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_db);
        db = new DatabaseHandler(this);
        for (int i = 0; i <= 4; i++)
            db.addContact(new Contact("8029599650" + i));
        contacts = new LinkedList<>(Arrays.asList(db.getAllContacts()));
        aa = new ArrayAdapter<String>(this, R.layout.items, contacts);
        list = findViewById(R.id.lv);
        list.setAdapter(aa);
        registerForContextMenu(list);
        list.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            public void onItemClick(AdapterView<?> parent, View v, int position, long id) {
                text = db.getContact(String.valueOf(((TextView) v).getText()));
                int duration = Toast.LENGTH_LONG;
                Context context = getApplicationContext();
                Toast.makeText(context, text, duration).show();
            }
        });

    }

    public void onCreateContextMenu(ContextMenu menu, View v, ContextMenu.ContextMenuInfo menuInfo) {
        super.onCreateContextMenu(menu, v, menuInfo);
        menu.add(0, CM_DELETE_ID, 0, R.string.delete_record);
        AdapterView.AdapterContextMenuInfo info = (AdapterView.AdapterContextMenuInfo) menuInfo;
        pos = info.position;
    }

    @Override
    public boolean onContextItemSelected(MenuItem item) {
        if(item.getItemId() == CM_DELETE_ID)
        {
            AdapterView.AdapterContextMenuInfo acmi = (AdapterView.AdapterContextMenuInfo) item.getMenuInfo();
            db.deleteContact(contacts.get((int)acmi.id));
            contacts.remove((int)acmi.id);
            this.aa.notifyDataSetChanged();
            return true;
        }
        return super.onContextItemSelected(item);
    }

    @Override
    protected void onPause() {
        super.onPause();
        db.deleteAll();
    }

    @Override
    protected void onDestroy() {
        super.onDestroy();
        db.deleteAll();
    }
}
