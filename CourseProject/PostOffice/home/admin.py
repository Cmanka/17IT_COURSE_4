from django.contrib import admin

from .models import *


class PostOfficeAdmin(admin.ModelAdmin):
    list_display = ('id', 'name', 'address')
    list_display_links = ('id', 'name')
    search_fields = ('name',)


class PositionAdmin(admin.ModelAdmin):
    list_display = ('id', 'name', 'salary')
    list_display_links = ('id', 'name', 'salary')
    search_fields = ('name', 'salary')


class EmployeeAdmin(admin.ModelAdmin):
    list_display = ('id', 'firstName', 'lastName', 'middleName')
    list_display_links = ('id', 'lastName')
    search_fields = ('lastName',)


class PublishingHouseAdmin(admin.ModelAdmin):
    list_display = ('id', 'name', 'address')
    list_display_links = ('id', 'name', 'address')
    search_fields = ('name',)


class PublicationAdmin(admin.ModelAdmin):
    list_display = ('id', 'name')
    list_display_links = ('id', 'name')
    search_fields = ('name',)


class ReleaseAdmin(admin.ModelAdmin):
    list_display = ('id', 'price', 'count')
    list_display_links = ('id', 'price')
    search_fields = ('price',)


class RegionAdmin(admin.ModelAdmin):
    list_display = ('id', 'index')
    list_display_links = ('id', 'index')
    search_fields = ('index',)


class HouseAdmin(admin.ModelAdmin):
    list_display = ('id', 'address')
    list_display_links = ('id', 'address')
    search_fields = ('address',)


class FollowerAdmin(admin.ModelAdmin):
    list_display = ('id', 'firstName', 'lastName', 'middleName')
    list_display_links = ('id', 'lastName')
    search_fields = ('lastName',)


class SubscriptionAdmin(admin.ModelAdmin):
    list_display = ('id', 'startDate', 'term')
    list_display_links = ('id', 'term')
    search_fields = ('term',)


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
