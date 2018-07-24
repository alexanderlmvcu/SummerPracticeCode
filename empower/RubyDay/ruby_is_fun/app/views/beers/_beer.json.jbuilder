json.extract! beer, :id, :name, :brewery, :price, :created_at, :updated_at
json.url beer_url(beer, format: :json)
