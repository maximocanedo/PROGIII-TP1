package com.max.arrozConLeche;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.List;

public class MyAdapter extends ArrayAdapter<String> {

    private final Context mContext;
    private final List<String> mValues;
    private final List<String> selectedValues;

    public MyAdapter(Context context, List<String> values) {
        super(context, R.layout.list_item, values);
        mContext = context;
        mValues = values;
        selectedValues = new ArrayList<String>();
    }
    public void add(String item) {
        boolean found = mValues.contains(item);
        if(!found) {
            mValues.add(item);
            notifyDataSetChanged();
        }
    }
    public List<String> getSelectedValues() {
        return selectedValues;
    }
    public List<String> getValues() {
        return mValues;
    }
    public void select(String content) {
        if(mValues.contains(content)) {
            selectedValues.add(content);
            notifyDataSetChanged();
        }
    }
    public void delete(String content) {
        if(mValues.contains(content)) {
            mValues.remove(content);
            notifyDataSetChanged();
        }
        if(selectedValues.contains(content)) {
            selectedValues.remove(content);
            notifyDataSetChanged();
        }
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        View view = convertView;
        if (view == null) {
            LayoutInflater inflater = (LayoutInflater) mContext.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
            view = inflater.inflate(R.layout.list_item, null);
        }
        CheckBox cbox = view.findViewById(R.id.listItemCbox);
        cbox.setText(mValues.get(position));
        cbox.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
                // Actualizar el valor de isSelected en la lista de elementos
                select(mValues.get(position));
            }
        });
        return view;
    }
}



