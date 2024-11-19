from django.contrib import admin
from django.urls import path, re_path
import HelloApp.views as ha
import apppath.views as pa

urlpatterns = [
    path('admin/', admin.site.urls),
    path('HelloPage/', ha.hello_view, name='helloview'),
    path('', ha.main_view, name='home'),
    path('FormPage/', ha.form_view, name='formview'),

    path('about/', pa.about, name='about'),
    path('about/contact/', pa.contact, name='contact_from_about'),
    path('contact/', pa.contact, name='contact_direct', kwargs={'name': 'Tom', 'address': 'Pavlova str'}),
]
