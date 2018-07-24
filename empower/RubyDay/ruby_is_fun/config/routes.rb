Rails.application.routes.draw do
  resources :beers
  root 'welcome#index'
  get 'home' => 'welcome#index'
  get  'we_rock'=> 'welcome#about'
  get 'drop_us_a_line' => 'welcome#contact'
  # For details on the DSL available within this file, see http://guides.rubyonrails.org/routing.html
end
