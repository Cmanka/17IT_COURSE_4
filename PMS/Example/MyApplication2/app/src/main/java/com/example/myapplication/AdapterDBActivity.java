package com.example.myapplication;

import android.database.Cursor;
import android.os.Bundle;
import android.view.ContextMenu;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.SimpleCursorAdapter;
import androidx.appcompat.app.AppCompatActivity;

public class AdapterDBActivity extends AppCompatActivity {
    AdapterHandler db;
    Cursor cursor;
    SimpleCursorAdapter adapter;
    private int CM_DELETE_ID = 1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_adapter_db);
        db = new AdapterHandler(this);
        db.open();
        cursor = db.getAllContacts();
        startManagingCursor(cursor);
        String[] from = new String[] {db.phone};
        int[] to = new int[] { R.id.items};
        adapter = new SimpleCursorAdapter(this, R.layout.items, cursor, from, to);
        ListView view = findViewById(R.id.alv);
        view.setAdapter(adapter);
        registerForContextMenu(view);
    }

    @Override
    public void onCreateContextMenu(ContextMenu menu, View v, ContextMenu.ContextMenuInfo menuInfo) {
        super.onCreateContextMenu(menu, v, menuInfo);
        menu.add(0, CM_DELETE_ID, 0, R.string.delete_record);
    }

    @Override
    public boolean onContextItemSelected(MenuItem item) {
        if(item.getItemId() == CM_DELETE_ID)
        {
            AdapterView.AdapterContextMenuInfo acmi = (AdapterView.AdapterContextMenuInfo) item.getMenuInfo();
            db.delContact(acmi.id);
            cursor.requery();
            return true;
        }
        return super.onContextItemSelected(item);
    }

    @Override
    protected void onPause() {
        super.onPause();
        db.close();
    }

    public void add(View view) {
        EditText text = findViewById(R.id.phone);
        db.addContact(new Contact(text.getText().toString()));
        cursor.requery();
    }
}
