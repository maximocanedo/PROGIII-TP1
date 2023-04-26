package com.max.arrozConLeche;

// Clase interna para mantener el estado de selección de los elementos
public class ListItem {
    private String text;
    private boolean selected;

    public ListItem(String text, boolean selected) {
        this.text = text;
        this.selected = selected;
    }

    public String getText() {
        return text;
    }

    public void setText(String text) {
        this.text = text;
    }

    public boolean isSelected() {
        return selected;
    }

    public void setSelected(boolean selected) {
        this.selected = selected;
    }
}
