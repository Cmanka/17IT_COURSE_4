package com.example.laba3;


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
    private int CM_UPDATE_ID = 2;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_db_adapter);
        db = new com.example.laba3.AdapterHandler(this);
        db.open();
        cursor = db.getAllContacts();
        startManagingCursor(cursor);
        String[] from = new String[]{db.phone};
        int[] to = new int[]{R.id.items};
        adapter = new SimpleCursorAdapter(this, R.layout.items, cursor, from, to);
        ListView view = findViewById(R.id.alv);
        view.setAdapter(adapter);
        registerForContextMenu(view);
    }

    @Override
    public void onCreateContextMenu(ContextMenu menu, View v, ContextMenu.ContextMenuInfo menuInfo) {
        super.onCreateContextMenu(menu, v, menuInfo);
        menu.add(0, CM_DELETE_ID, 0, R.string.delete_record);
        menu.add(1, CM_UPDATE_ID, 1, R.string.update_record);
    }

    @Override
    public boolean onContextItemSelected(MenuItem item) {
        if (item.getItemId() == CM_DELETE_ID) {
            AdapterView.AdapterContextMenuInfo acmi = (AdapterView.AdapterContextMenuInfo) item.getMenuInfo();
            db.delContact(acmi.id);
            cursor.requery();
            return true;
        }
        if (item.getItemId() == CM_UPDATE_ID) {
            AdapterView.AdapterContextMenuInfo acmi = (AdapterView.AdapterContextMenuInfo) item.getMenuInfo();
            EditText text = findViewById(R.id.phone);
            db.updateContact(acmi.id,text.getText().toString());
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
