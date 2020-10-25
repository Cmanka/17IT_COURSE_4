from django import forms
from home.models import Employee, Follower_Subscription
import re
from django.core.exceptions import ValidationError


class PostOfficePublicationsQueryForm(forms.Form):
    post_office_name = forms.ChoiceField()


class PostmanAddressForm(forms.Form):
    address = forms.ChoiceField()


class FollowerForm(forms.Form):
    followers = forms.ChoiceField()


class PostmanForm(forms.ModelForm):
    class Meta:
        model = Employee
        fields = ['last_name', 'first_name', 'middle_name', 'email', 'phone', 'post_office', 'position']
        widgets = {
            'last_name': forms.TextInput(attrs={'class': 'form-control'}),
            'first_name': forms.TextInput(attrs={'class': 'form-control'}),
            'middle_name': forms.TextInput(attrs={'class': 'form-control'}),
            'email': forms.EmailInput(attrs={'class': 'form-control'}),
            'phone': forms.TextInput(attrs={'class': 'form-control'}),
            'post_office': forms.Select(attrs={'class': 'form-control'}),
            'position': forms.HiddenInput(),
        }

    def clean_first_name(self):
        first_name = self.cleaned_data['first_name']
        if re.search('\d', first_name):
            raise ValidationError('Field cannot contain numbers in name')
        return first_name

    def clean_last_name(self):
        last_name = self.cleaned_data['last_name']
        if re.search('\d', last_name):
            raise ValidationError('Field cannot contain numbers in name')
        return last_name

    def clean_middle_name(self):
        middle_name = self.cleaned_data['middle_name']
        if re.search('\d', middle_name):
            raise ValidationError('Field cannot contain numbers in name')
        return middle_name

