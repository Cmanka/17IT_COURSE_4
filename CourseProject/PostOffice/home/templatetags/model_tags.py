from django import template
from django.core.paginator import Paginator
from django.db.models import Count
from django.views.generic import ListView

from home.models import *

register = template.Library()




# @register.inclusion_tag('home/tags/post_office_record.html')
# def show_post_office(post_office_id):
#     post_office = PostOffice.objects.get(pk=post_office_id)
#     employees = PostOffice.objects.get(pk=post_office_id).employee_set.all()
#     postmen = PostOffice.objects.get(pk=post_office_id).employee_set.annotate(cnt=Count('post_office')).filter(
#         position__name='Postman')
#     operators = PostOffice.objects.get(pk=post_office_id).employee_set.annotate(cnt=Count('post_office')).filter(
#         position__name='Operator')
#     regions = PostOffice.objects.get(pk=post_office_id).region_set.all()
#     publications = PostOffice.objects.get(pk=post_office_id).release_set.all()
#     context = {
#         'post_office': post_office,
#         'employees': employees,
#         'postmen': postmen,
#         'operators': operators,
#         'regions': regions,
#         'publications': publications,
#     }
#
#     return context
#
#
# @register.inclusion_tag('home/tags/publishing_houses_list.html')
# def show_publishing_houses():
#     publishing_houses = PublishingHouse.objects.all()
#     return {"publishing_houses": publishing_houses}
#
#
# @register.inclusion_tag('home/tags/publishing_house_record.html')
# def show_publishing_house(publishing_house_id):
#     publishing_house = PublishingHouse.objects.get(pk=publishing_house_id)
#     publications = PublishingHouse.objects.get(pk=publishing_house_id).publication_set.all()
#     context = {
#         'publishing_house': publishing_house,
#         'publications': publications,
#     }
#
#     return context
#
#
# @register.inclusion_tag('home/tags/regions_list.html')
# def show_regions():
#     regions = Region.objects.all()
#     return {"regions": regions}
#
#
# @register.inclusion_tag('home/tags/region_record.html')
# def show_region(region_id):
#     region = Region.objects.get(pk=region_id)
#     context = {
#         'region': region,
#     }
#
#     return context
#
#
# @register.inclusion_tag('home/tags/houses_list.html')
# def show_houses():
#     houses = House.objects.all()
#     return {"houses": houses}
#
#
# @register.inclusion_tag('home/tags/house_record.html')
# def show_house(house_id):
#     house = House.objects.get(pk=house_id)
#     context = {
#         'house': house,
#     }
#
#     return context
#
#
# @register.inclusion_tag('home/tags/publications_list.html')
# def show_publications():
#     publications = Release.objects.all()
#     return {"publications": publications}
#
#
# @register.inclusion_tag('home/tags/publication_record.html')
# def show_publication(publication_id):
#     publication = Release.objects.get(pk=publication_id)
#     context = {
#         'publication': publication,
#     }
#
#     return context
#
#
# @register.inclusion_tag('home/tags/subscriptions_list.html')
# def show_subscriptions():
#     subscriptions = Subscription.objects.all()
#     return {"subscriptions": subscriptions}
#
#
# @register.inclusion_tag('home/tags/subscription_record.html')
# def show_subscription(subscription_id):
#     subscription = Subscription.objects.get(pk=subscription_id)
#     context = {
#         'subscription': subscription,
#     }
#
#     return context
#
#
# @register.inclusion_tag('home/tags/followers_list.html')
# def show_followers():
#     followers = Follower.objects.all()
#     return {"followers": followers}
#
#
# @register.inclusion_tag('home/tags/follower_record.html')
# def show_follower(follower_id):
#     follower = Follower.objects.get(pk=follower_id)
#     context = {
#         'follower': follower,
#     }
#
#     return context
