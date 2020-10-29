from django.contrib import admin
from django.core.checks import messages
from django.core.mail import send_mail

from .models import *


class PostOfficeAdmin(admin.ModelAdmin):
    list_display = ('id', 'name', 'address')
    list_display_links = ('id', 'name', 'address')
    search_fields = ('name',)


class PositionAdmin(admin.ModelAdmin):
    list_display = ('id', 'name', 'salary')
    list_display_links = ('id', 'name', 'salary')
    search_fields = ('name', 'id')


class EmployeeAdmin(admin.ModelAdmin):
    list_display = (
        'id', 'first_name', 'last_name', 'middle_name', 'email', 'phone', 'position', 'post_office')
    list_display_links = (
        'id', 'first_name', 'last_name', 'middle_name', 'email', 'phone', 'position', 'post_office')
    search_fields = ('lastName', 'email', 'id')


class PublishingHouseAdmin(admin.ModelAdmin):
    list_display = ('id', 'name', 'address')
    list_display_links = ('id', 'name', 'address')
    search_fields = ('name', 'id')


class PublicationAdmin(admin.ModelAdmin):
    list_display = ('id', 'name', 'publishing_house')
    list_display_links = ('id', 'name', 'publishing_house')
    search_fields = ('name', 'id')


class ReleaseAdmin(admin.ModelAdmin):
    list_display = ('id', 'price', 'count', 'publication','post_office')
    list_display_links = ('id', 'price', 'count', 'publication','post_office')
    search_fields = ('price', 'id', 'count')


class RegionAdmin(admin.ModelAdmin):
    list_display = ('id', 'index', 'post_office', 'postman')
    list_display_links = ('id', 'index', 'post_office', 'postman')
    search_fields = ('index', 'id')


class HouseAdmin(admin.ModelAdmin):
    list_display = ('id', 'address', 'region')
    list_display_links = ('id', 'address', 'region')
    search_fields = ('address', 'id')


class FollowerAdmin(admin.ModelAdmin):
    list_display = ('id', 'first_name', 'last_name', 'middle_name', 'email', 'phone', 'house')
    list_display_links = ('id', 'first_name', 'last_name', 'middle_name', 'email', 'phone', 'house')
    search_fields = ('lastName', 'id', 'email')


class SubscriptionAdmin(admin.ModelAdmin):
    list_display = ('id', 'start_date', 'term', 'end_date', 'description', 'release')
    list_display_links = ('id', 'start_date', 'term', 'end_date', 'description', 'release')
    search_fields = ('term', 'id',)


class SubFollAdmin(admin.ModelAdmin):
    list_display = ('id', 'follower', 'subscription')

    def save_model(self, request, obj, form, change):
        mail = send_mail('Subscribing',
                         f'Total price:{obj.subscription.total_price()}$\n'
                         f'Term:{obj.subscription.term} month\n'
                         f'Publication:{obj.subscription.release.publication.name}\n'
                         f'Description:{obj.subscription.description}',
                         'andrewlabun934@gmail.com',
                         [f'{obj.follower.email}','offatrubkin@gmail.com'],
                         fail_silently=True)
        if mail:
            print('success')
            obj.save()
        else:
            print('error')


admin.site.register(PostOffice, PostOfficeAdmin)
admin.site.register(Position, PositionAdmin)
admin.site.register(Employee, EmployeeAdmin)
admin.site.register(PublishingHouse, PublishingHouseAdmin)
admin.site.register(Publication, PublicationAdmin)
admin.site.register(Release, ReleaseAdmin)
admin.site.register(Region, RegionAdmin)
admin.site.register(House, HouseAdmin)
admin.site.register(Follower, FollowerAdmin)
admin.site.register(Subscription, SubscriptionAdmin)
admin.site.register(Follower_Subscription, SubFollAdmin)

admin.site.site_header = 'Information system'
admin.site.site_title = 'Manage information system'
