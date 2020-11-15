package com.example.laba3;


import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

public class AdapterHandler
{
    public static final String id = "_id";
    public static final String phone = "phoneNumber";
    ;
    private static final int version = 1;
    private static final String name = "contactsManagers";
    private static final String table = "contacts";
    private static final String create = "create table " + table + "(" + id + " integer primary key autoincrement, " + phone + " text" + ")";

    private Context context;
    private DBHandler handler;
    private SQLiteDatabase db;

    public AdapterHandler(Context context) {
        this.context = context;
    }

    public void open() {
        handler = new DBHandler(context, name, null, version);
        db = handler.getWritableDatabase();
    }

    public void close() {
        if (db != null) handler.close();
    }

    public Cursor getAllContacts() {
        return db.query(table, new String[]{id, phone}, null, null, null, null, null, null);
    }

    public void delContact(long _id) {
        db.delete(table, id + " = " + _id, null);
    }
    public void updateContact(long _id, String number) {
        ContentValues value = new ContentValues();
        value.put(phone, number);
        db.update(table, value ,id + " = " + _id, null);
    }
    public void deleteAll() {
        db.delete(table, null, null);
    }

    public void addContact(Contact contact) {
        ContentValues values = new ContentValues();
        values.put(phone, contact.getPhoneNumber());
        db.insert(table, null, values);
    }

    private class DBHandler extends SQLiteOpenHelper {

        public DBHandler(Context context, String name, SQLiteDatabase.CursorFactory factory, int version) {
            super(context, name, factory, version);
        }

        @Override
        public void onCreate(SQLiteDatabase db) {
            db.execSQL(create);
        }

        @Override
        public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
            db.execSQL("drop table if exists " + table);
            onCreate(db);
        }
    }
}
