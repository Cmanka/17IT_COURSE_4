package com.example.laba3;


import android.content.ContentValues;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.content.Context;

public class DatabaseHandler extends SQLiteOpenHelper{

    private static final int version = 1;
    private static final String name = "contactsManager";
    private String contacts = "contacts";
    public String id = "id";
    public String phoneNumber = "phoneNumber";



    public DatabaseHandler(Context context) {
        super(context, name, null, version);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        String create = "create table " + contacts + "(" + id + " integer primary key autoincrement, " +phoneNumber + " text" + ")";
        db.execSQL(create);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL("drop table if exists " + contacts);
        onCreate(db);
    }

    public void addContact(Contact contact) {
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues values = new ContentValues();
        values.put(phoneNumber, contact.getPhoneNumber());
        db.insert(contacts, null, values);
        db.close();
    }

    public String getContact(String phone) {
        SQLiteDatabase db = this.getReadableDatabase();
        Cursor cursor = db.query(contacts, new String[] { id, phoneNumber }, phoneNumber + "=?",
                new String[] { String.valueOf(phone) }, null, null, null, null);

        if (cursor != null){
            cursor.moveToFirst();
        }
        return cursor.getString(0);
    }

    public String[] getAllContacts() {
        String selectQuery = "select  * from " + contacts;
        String[] contact = new String[0];
        SQLiteDatabase db = this.getWritableDatabase();
        Cursor cursor = db.rawQuery(selectQuery, null);

        if (cursor.moveToFirst()) {
            do {
                contact = increaseArray(contact);
                contact[contact.length - 1] = cursor.getString(1);
            } while (cursor.moveToNext());
        }
        return contact;
    }

    private String[] increaseArray(String[] theArray)
    {
        int i = theArray.length;
        int n = ++i;
        String[] newArray = new String[n];
        for(int cnt=0;cnt<theArray.length;cnt++)
            newArray[cnt] = theArray[cnt];
        return newArray;
    }

    public void deleteContact(String number) {
        SQLiteDatabase db = this.getWritableDatabase();
        db.delete(contacts, phoneNumber + " = ?", new String[] { String.valueOf(number) });
        db.close();
    }

    public void deleteAll() {
        SQLiteDatabase db = this.getWritableDatabase();
        db.delete(contacts, null, null);
        db.close();
    }
}
